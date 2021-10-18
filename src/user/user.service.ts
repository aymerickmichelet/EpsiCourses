import { getRepository } from "typeorm";
import * as bcrypt from 'bcrypt';
import * as jwt from 'jsonwebtoken';

import { User } from "./entity/User"

const userRepository = () => getRepository(User);
const JSON_SIGN_SECRET = "jaàdjapzjdpoajpJOPHOPHPNPOY1PU0°U0PNOuà)nopnlmnopU0°1J0¨4557487876988743"

function generateToken(userId){
    return jwt.sign({
        userId: userId
    },
    JSON_SIGN_SECRET,
    {
        expiresIn: '30m'
    })
}

export const findUserById = async (userId) => {
    const user = await userRepository().findOne({where: {
        id: userId
    }});
    return user;
};

export const checkUsernameAndPassword = async (username, password) => {
    
    const user = await userRepository().findOne({where: {
        username: username
    }});

    if(bcrypt.compareSync(password, user.password)){
        return {
            "user_id": user.id,
            "token": generateToken(user.id)
        }
    }else{
        return {
            "error: ": "Wrong password"
        }
    }
};

export const createUser = async (data) => {

    const user = await userRepository().findOne({where: {
        username: data.username
    }});

    if (user !== undefined) return "409 Conflict";

    const hash = await bcrypt.hash(data.password, 10);

    const newUser = userRepository().create({ 
        username: data.username,
        password: hash
    });
    
    return await userRepository().save(newUser);
}

export const editUser = async (newUser) => {

    let user = await userRepository().findOne({ where: {
            id: newUser.id
    }});

    user = {
        ...user,
        ...newUser
    }

    return await userRepository().save(user);
}

export const deleteUser = async (userId) => { //enable with 1 ou several id in array
    return await userRepository().delete(userId);
}