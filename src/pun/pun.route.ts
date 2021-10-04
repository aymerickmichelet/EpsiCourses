
import * as Router from "koa-router"; 
import { editPun, addPun, getPun } from "./pun.controller";

const router: Router = new Router(); 

router.get('/pun', getPun);
router.get('/pun/:id', getPun);
router.post('/pun', addPun);
// router.put('/pun', editPun);

export default router;