import * as Koa from 'koa';
import * as bodyParser from 'koa-bodyparser';
import * as cors from '@koa/cors';

//routes
import punRouter from './pun/pun.route';
const app:Koa = new Koa();

app.use(cors({
    origin: "*"
})); 
app.use(bodyParser());

//routes
app.use(punRouter.routes())

app.on('error', console.error); 

export default app; 