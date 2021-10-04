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
        let bodyPun = {};
        let pun = context.request.body;
        bodyPun["id"] = pun.id;
        if(pun.firstname !== undefined) bodyPun["firstname"] = pun.firstname;
        if(pun.lastname !== undefined) bodyPun["lastname"] = pun.lastname;
        if(pun.author !== undefined) bodyPun["author"] = pun.author;
        bodyPun["date_modification"] = Date();

        pun = await editPun(bodyPun);
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

export const addPuns = async (context: Context, next: Next) => {
    try {
        const data = context.request.body;
        let output = [];
        for(let i = 0, imax = data.length; i < imax; i++)
            output.push(await createPun(data[i]));
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

export const setPuns = async (context: Context, next: Next) => {
    try {
        const data = context.request.body;
        let output = [];

        for(let i = 0, imax = data.length; i < imax; i++){
            let pun = data[i];
            
            let bodyPun = {};
            bodyPun["id"] = pun.id;
            if(pun.firstname !== undefined) bodyPun["firstname"] = pun.firstname;
            if(pun.lastname !== undefined) bodyPun["lastname"] = pun.lastname;
            if(pun.author !== undefined) bodyPun["author"] = pun.author;
            bodyPun["date_modification"] = Date();

            output.push(await editPun(bodyPun));
        }
        context.response.status = 200;
        context.response.body = output;

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