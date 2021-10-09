import {MigrationInterface, QueryRunner} from "typeorm";

export class addValidate1633767074918 implements MigrationInterface {
    name = 'addValidate1633767074918'

    public async up(queryRunner: QueryRunner): Promise<void> {
        await queryRunner.query(`ALTER TABLE \`pun-db\`.\`pun\` DROP COLUMN \`username\``);
        await queryRunner.query(`ALTER TABLE \`pun-db\`.\`pun\` DROP COLUMN \`password\``);
    }

    public async down(queryRunner: QueryRunner): Promise<void> {
        await queryRunner.query(`ALTER TABLE \`pun-db\`.\`pun\` ADD \`password\` varchar(255) NOT NULL`);
        await queryRunner.query(`ALTER TABLE \`pun-db\`.\`pun\` ADD \`username\` varchar(255) NOT NULL`);
    }

}
