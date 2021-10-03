import { Column, Entity, ManyToOne, OneToMany, PrimaryColumn, TableForeignKey } from "typeorm";
// import { User } from "../../user/entity/User";

@Entity()
export class Pun {

    @PrimaryColumn()
    id: number;

    @Column()
    firstname: string; 

    @Column()
    lastname: string; 

    @Column()
    author: string;

    @Column()
    date_creation: Date; 

    @Column()
    date_modification: Date; 

    // @ManyToOne(() => User, user => user.campaign)
    // user: User;
}