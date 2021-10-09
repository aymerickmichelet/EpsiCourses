import { getRepository } from "typeorm";
import { Pun } from "./entity/Pun"
// import { v4 as uuidv4 } from 'uuid'

const punRepository = () => getRepository(Pun);

export const findRandomPun = async () => {
    const pun = await punRepository().createQueryBuilder('pun')
        .where('validate = :validate', { validate: true })
        .orderBy('RAND()')
        .limit(1)
        .getOne();
    return pun;
};

export const findPunById = async (punId) => {
    const pun = await punRepository().findOne({where: {
        id: punId
    }});
    return pun;
};

export const findPuns = async (punIdBegin, count, validate) => {
    const pun = await punRepository().createQueryBuilder('pun')
        .where('validate = :validate', { validate: validate })
        .andWhere('id >= :id', { id: punIdBegin })
        .limit(count)
        .getMany();
    return pun;
};

export const createPun = async (data) => {
    
    let validate = false;
    if (data.validate) validate = data.validate;
    const newPun = punRepository().create({ 
        firstname: data.firstname,
        lastname: data.lastname,
        author: data.author,
        validate: validate,
        date_creation: Date(),
        date_modification: Date()
    });
    
    return await punRepository().save(newPun);
}

export const editPun = async (newPun) => {

    let pun = await punRepository().findOne({ where: {
            id: newPun.id
    }});

    pun = {
        ...pun,
        ...newPun
    }

    return await punRepository().save(pun);
}

export const deletePun = async (punId) => { //enable with 1 ou several id in array
    return await punRepository().delete(punId);
}