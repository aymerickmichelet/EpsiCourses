
import * as Router from "koa-router"; 
import { getPun } from "./pun.controller";

const router: Router = new Router(); 

router.get('/pun', getPun);
// router.get('/campaign/:campaignId', authAccess, getOneCampaign);

export default router;