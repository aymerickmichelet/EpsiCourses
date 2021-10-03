import * as dotenv from "dotenv";
import * as env from "getenv";

dotenv.config();

export default {
  server: {
    port: env.int("PORT", 8000),
  },
};
