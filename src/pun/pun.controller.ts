import { Context, Next } from "koa";
import ErrorMsg from "../interface/ErrorMsg";
import { findRandomPun, findPunById, findPuns, createPun, editPun, deletePun } from "./pun.service";


function parseBody(pun){
    let bodyPun = {};
    bodyPun["id"] = pun.id;
    if(pun.firstname !== undefined) bodyPun["firstname"] = pun.firstname;
    if(pun.lastname !== undefined) bodyPun["lastname"] = pun.lastname;
    if(pun.author !== undefined) bodyPun["author"] = pun.author;
    if(pun.validate != undefined) bodyPun["validate"] = pun.validate;
    bodyPun["date_modification"] = Date();
    return bodyPun;
}

export const getPun = async (context: Context, next: Next) => {
    try {
        let pun = null;
        if (context.params.id != null){
            pun = await findPunById(context.params.id);
        }else{
            pun = await findRandomPun();
        }
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

export const getPuns = async (context: Context, next: Next) => {
    try {
        const puns = await findPuns(
            context.params.idBegin,
            context.params.count,
            context.params.validate);        
        context.response.status = 200;
        context.response.body = puns;

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

export const setPun = async (context: Context, next: Next) => {
    try {
        const bodyPun = parseBody(context.request.body);
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

export const removePun = async (context: Context, next: Next) => {
    try {
        const pun = await deletePun(context.params.id);
        context.response.status = 200;
        context.response.body = {
            "deleted": 1
        };

        next();
    } catch(error) {
        console.log('error', error)
        const errorMsg: ErrorMsg = {
            status: 400, 
            msg: "Couldn't delete the pun"
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
            
            const bodyPun = parseBody(pun);
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

export const removePuns = async (context: Context, next: Next) => {
    try {
        const data = context.request.body.id;
        await deletePun(context.request.body.id);
        context.response.status = 200;
        context.response.body = {
            "deleted": data.length
        };

        next();
    } catch(error) {
        console.log('error', error)
        const errorMsg: ErrorMsg = {
            status: 400, 
            msg: "Couldn't delete the pun"
        }

        context.response.status = 400; 
        context.response.body = errorMsg
    }
}