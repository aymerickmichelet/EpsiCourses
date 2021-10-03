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

// export const createCampaign = async (data, user) => {

//     const employees = data.employees.map(employee => ({
//         ...employee, 
//         id: uuidv4()
//     }))

//     const newCampaign = campaignRepository().create({ 
//         id: uuidv4(), 
//         title: data.title, 
//         template: data.template, 
//         sent: false,
//         date: Date(), 
//         employee: employees, 
//         user: user
//     })
    
//     return await campaignRepository().save(newCampaign);
// }

// export const editPun = async (pun) => {

// }