import { Department } from "./department";
import { Skill } from "./skill";

export interface Employee extends Department
{
    id:number;
    name:string;
    salary:number;
    permanent:boolean;
    skills:Skill[];
}