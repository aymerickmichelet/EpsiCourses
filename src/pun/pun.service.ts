import { getRepository } from "typeorm";
import { Pun } from "./entity/Pun"
// import { v4 as uuidv4 } from 'uuid'

const punRepository = () => getRepository(Pun);

export const findPun = async () => {
    const pun = await punRepository().query(`
        SELECT * FROM pun
        ORDER BY RAND()
        LIMIT 1`);
    return pun[0];
};

export const findPunById = async (punId) => {
    const pun = await punRepository().findOne({where: {
        id: punId
    }});
    return pun;
};

export const createPun = async (data) => {

    const newPun = punRepository().create({ 
        firstname: data.firstname,
        lastname: data.lastname,
        author: data.author,
        date_creation: Date(),
        date_modification: Date()
    });
    
    return await punRepository().save(newPun);
}

// export const editPun = async (pun) => {

// }