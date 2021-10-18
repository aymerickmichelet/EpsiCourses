
import * as Router from "koa-router"; 
import { authAccess } from "../middleware/auth";
import { setPun, addPun, getPun, getPuns, addPuns, setPuns, removePun, removePuns } from "./pun.controller";

const router: Router = new Router(); 

router.get('/pun', getPun);
router.get('/pun/:id', getPun);
router.get('/pun/:idBegin/:count/:validate', getPuns);
router.post('/pun', addPun);
router.put('/pun', authAccess, setPun);
router.delete('/pun/:id', authAccess, removePun);
router.delete('/puns', authAccess, removePuns);
router.post('/puns', authAccess, addPuns);
router.put('/puns', authAccess, setPuns);

export default router;