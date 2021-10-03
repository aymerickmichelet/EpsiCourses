import { Context, Next } from "koa";
import ErrorMsg from "../interface/ErrorMsg";
import { findPun, findPunById } from "./pun.service";

// import { findAllCampaign, findCampaignById, createCampaign } from "./pun.service";

export const getPun = async (context: Context, next: Next) => {
    try {
        let id = null, pun = null;
        if (context.params.id != null) id = context.params.id;
        (id != null) ? pun = await findPunById(id) : pun = await findPun();
        context.response.status = 200;
        context.response.body = pun;

        next()
    } catch(error) {
        console.log('error', error)
        const errorMsg: ErrorMsg = {
            status: 400, 
            msg: "Couldn't get pun"
        }

        context.response.status = 400; 
        context.response.body = errorMsg
    }
};

export const createPun = async (context: Context, next: Next) => {
    // try {
    //     const user = context.state.user; 
    //     const data = context.request.body;
    //     console.log(data);
        
    //     const output = await createCampaign(data, user);
    //     context.response.status = 200;
    //     context.response.body = output;

    //     next()
    // } catch(error) {
    //     console.log('error', error)
    //     const errorMsg: ErrorMsg = {
    //         status: 400, 
    //         msg: "Couldn't create a new campaign"
    //     }

    //     context.response.status = 400; 
    //     context.response.body = errorMsg
    // }
};

export const editPun = async (context: Context, next: Next) => {

}