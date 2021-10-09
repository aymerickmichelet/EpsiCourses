
import * as Router from "koa-router"; 
import { setPun, addPun, getPun, getPuns, addPuns, setPuns, removePun, removePuns } from "./pun.controller";

const router: Router = new Router(); 

router.get('/pun', getPun);
router.get('/pun/:id', getPun);
router.get('/pun/:idBegin/:count/:validate', getPuns);
router.post('/pun', addPun);
router.put('/pun', setPun);
router.delete('/pun/:id', removePun);
router.delete('/puns', removePuns);
router.post('/puns', addPuns);
router.put('/puns', setPuns);

export default router;