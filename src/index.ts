import "reflect-metadata";
import { createConnection } from "typeorm";

import app from "./app";
import config from "./config";

const normalizePort = (val) => { 
    const port = parseInt(val, 10);
    if (isNaN(port)) {
      return val;
    }
    if (port >= 0) {
      return port;
    }
    return false;
  };

const port = normalizePort(config.server.port);

const lauchServer = async () => {
  try {
    await createConnection();
    app.listen(port);
    console.log(`Koa server has starded on port ${port}`);
  } catch (error) {
    console.log(error);
  }
};

lauchServer();