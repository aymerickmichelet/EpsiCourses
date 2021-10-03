import { getRepository } from "typeorm";
import { Pun } from "./entity/Pun"
// import { v4 as uuidv4 } from 'uuid'

const punRepository = () => getRepository(Pun);


// export const findCampaign = async (campaignId) => {
//     const campaign = await campaignRepository().findOne({where: {
//         id: campaignId
//     }});
//     return campaign;
// };

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