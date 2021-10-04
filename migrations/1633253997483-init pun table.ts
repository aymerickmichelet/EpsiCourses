import {MigrationInterface, QueryRunner} from "typeorm";

export class initPunTable1633253997483 implements MigrationInterface {
    name = 'initPunTable1633253997483'

    public async up(queryRunner: QueryRunner): Promise<void> {
        await queryRunner.query(`CREATE TABLE \`pun-db\`.\`pun\` (\`id\` int NOT NULL AUTO_INCREMENT, \`firstname\` varchar(255) NOT NULL, \`lastname\` varchar(255) NOT NULL, \`author\` varchar(255) NULL, \`date_creation\` datetime NOT NULL, \`date_modification\` datetime NOT NULL, PRIMARY KEY (\`id\`)) ENGINE=InnoDB`);
    }

    public async down(queryRunner: QueryRunner): Promise<void> {
        await queryRunner.query(`DROP TABLE \`pun-db\`.\`pun\``);
    }

}
