import { Context, Next } from "koa";
import ErrorMsg from "../interface/ErrorMsg";
import { createUser, checkUsernameAndPassword } from "./user.service";

function parseBody(user){
    let bodyUser = {};
    if(user.id !== undefined) bodyUser["id"] = user.id;
    if(user.username !== undefined) bodyUser["username"] = user.username;
    if(user.password !== undefined) bodyUser["password"] = user.password;
    return bodyUser;
}

export const registerUser = async (context: Context, next: Next) => {
    try {
        const bodyUser = parseBody(context.request.body);
        const user = await createUser(bodyUser);
        context.response.status = 200;
        context.response.body = {
            "response": "The user has been created !"
        };

        next();
    } catch(error) {
        console.log('error', error)
        const errorMsg: ErrorMsg = {
            status: 400, 
            msg: "Couldn't create the user"
        }

        context.response.status = 400; 
        context.response.body = errorMsg
    }
}

export const loginUser = async (context: Context, next: Next) => {
    try {
        const response = await checkUsernameAndPassword(
            context.request.body.username,
            context.request.body.password);
        context.response.status = 200;
        context.response.body = response;

        next()
    } catch(error) {
        console.log('error', error)
        const errorMsg: ErrorMsg = {
            status: 400, 
            msg: "Couldn't get user"
        }

        context.response.status = 400; 
        context.response.body = errorMsg
    }
};