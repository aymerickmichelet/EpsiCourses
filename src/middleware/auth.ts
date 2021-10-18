import { Context, Next } from "koa";

import * as jwt from 'jsonwebtoken';
import ErrorMessage from '../interface/ErrorMsg';
import { findUserById } from "../user/user.service";


export const authAccess = async (context: Context, next: Next) => {

    try {
        const token = context.request.headers.authorization; 
        const auth = jwt.verify(token, "jaàdjapzjdpoajpJOPHOPHPNPOY1PU0°U0PNOuà)nopnlmnopU0°1J0¨4557487876988743");
        const user = await findUserById(auth.userId);
        context.state.user = {
            id: user.id,
            username: user.username
        };
        context.response.status = 200;
        
        await next();
    } catch(error) {
        const errorMsg: ErrorMessage = {
            status: 401, 
            msg: "Unauthenticated request"
        }

        context.response.status = errorMsg.status; 
        context.response.body = errorMsg; 
    }
}