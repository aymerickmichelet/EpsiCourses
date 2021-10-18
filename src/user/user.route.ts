
import * as Router from "koa-router"; 
import { registerUser, loginUser } from "./user.controller";
import { authAccess } from "../middleware/auth";

const router: Router = new Router(); 

router.post('/user/register', authAccess, registerUser);
router.post('/user/login', loginUser);
// router.get('/auth', authAccess)

export default router;