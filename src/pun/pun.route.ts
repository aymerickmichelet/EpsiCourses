
import * as Router from "koa-router"; 
import { setPun, addPun, getPun, addPuns, setPuns } from "./pun.controller";

const router: Router = new Router(); 

router.get('/pun', getPun);
router.get('/pun/:id', getPun);
router.post('/pun', addPun);
router.put('/pun', setPun);
router.post('/puns', addPuns);
router.put('/puns', setPuns);

export default router;