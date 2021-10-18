import {MigrationInterface, QueryRunner} from "typeorm";

export class createUser1633786926583 implements MigrationInterface {
    name = 'createUser1633786926583'

    public async up(queryRunner: QueryRunner): Promise<void> {
        await queryRunner.query(`CREATE TABLE \`pun-db\`.\`user\` (\`id\` int NOT NULL AUTO_INCREMENT, \`username\` varchar(255) NOT NULL, \`password\` varchar(255) NOT NULL, PRIMARY KEY (\`id\`)) ENGINE=InnoDB`);
    }

    public async down(queryRunner: QueryRunner): Promise<void> {
        await queryRunner.query(`DROP TABLE \`pun-db\`.\`user\``);
    }

}
