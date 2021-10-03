import { Column, Entity, ManyToOne, OneToMany, PrimaryGeneratedColumn, TableForeignKey } from "typeorm";
// import { User } from "../../user/entity/User";

@Entity()
export class Pun {

    @PrimaryGeneratedColumn('increment')
    id: number;

    @Column()
    firstname: string; 

    @Column()
    lastname: string; 

    @Column({
        nullable: true
    })
    author: string;
    
    @Column()
    date_creation: Date; 

    @Column()
    date_modification: Date; 

    // @ManyToOne(() => User, user => user.campaign)
    // user: User;
}