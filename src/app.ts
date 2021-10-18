import * as Koa from 'koa';
import * as bodyParser from 'koa-bodyparser';
import * as cors from '@koa/cors';

//routes
import punRouter from './pun/pun.route';
import userRouter from './user/user.route';
const app:Koa = new Koa();

app.use(cors({
    origin: "*"
})); 
app.use(bodyParser());

//routes
app.use(punRouter.routes())
app.use(userRouter.routes())

app.on('error', console.error); 

export default app; 