import { Context, Next } from "koa";
import ErrorMsg from "../interface/ErrorMsg";
import { findPun, findPunById, createPun, editPun } from "./pun.service";

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

export const addPun = async (context: Context, next: Next) => {
    try {
        const data = context.request.body;
        const output = await createPun(data);
        context.response.status = 200;
        context.response.body = output;

        next()
    } catch(error) {
        console.log('error', error)
        const errorMsg: ErrorMsg = {
            status: 400, 
            msg: "Couldn't create a new pun"
        }

        context.response.status = 400; 
        context.response.body = errorMsg
    }
};

export const setPun = async (context: Context, next: Next) => {
    try {
        const bodyPun = {
            id: context.request.body.id,
            firstname: context.request.body.firstname,
            lastname: context.request.body.lastname,
            author: context.request.body.author,
            date_modification: Date()
        }
        const pun = await editPun(bodyPun);
        context.response.status = 200;
        context.response.body = pun;

        next();
    } catch(error) {
        console.log('error', error)
        const errorMsg: ErrorMsg = {
            status: 400, 
            msg: "Couldn't edit the pun"
        }

        context.response.status = 400; 
        context.response.body = errorMsg
    }
}