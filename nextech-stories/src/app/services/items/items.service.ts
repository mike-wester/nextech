import { Injectable } from '@angular/core';
import { Observable, ReplaySubject } from 'rxjs';
import { Item } from '../../classes/item';

@Injectable({
  providedIn: 'root'
})
export class ItemsService {

  private _item: Item[] = [];
  private _itemSubject: ReplaySubject<Item[]> = new ReplaySubject(1);

  constructor() { }

  public getItems = (): Observable<Item[]> => this._itemSubject.asObservable();

}
