import { ItemType } from '../enums/item-type';
import { IItem } from '../interfaces/iItem';

export class Item implements IItem {

  public id: number;
  public deleted: boolean;
  public type: ItemType;
  public by: string;
  public time: number;
  public text: string;
  public dead: boolean;
  public parent: number;
  public poll: number;
  public kids: number[];
  public url: string;
  public score: number;
  public title: string;
  public parts: number[];
  public descendants: number[];

  constructor(input: IItem) {

    this.id = input.id || 0;
    this.deleted = input.deleted || false;
    this.type = input.type;
    this.by = input.by;
    this.time = input.time;
    this.text = input.text;
    this.dead = input.dead;
    this.parent = input.parent;
    this.poll = input.poll;
    this.kids = input.kids;
    this.url = input.url;
    this.score = input.score;
    this.title = input.title;
    this.parts = input.parts;
    this.descendants = input.descendants;

  }
}
