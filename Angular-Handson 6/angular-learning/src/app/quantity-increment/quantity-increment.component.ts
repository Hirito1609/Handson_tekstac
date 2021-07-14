import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-quantity-increment',
  templateUrl: './quantity-increment.component.html',
  styleUrls: ['./quantity-increment.component.css'],
})
export class QuantityIncrementComponent implements OnInit {
  constructor() {}

  ngOnInit(): void {}

  public result: string = '';
  public firstbutton(): void {
    this.result = 'click me button clicked';
  }
  public num: number = 0;
  public Add(): void {
    this.num++;
  }
  public addandsub: number = 0;
  public flag: boolean = true;

  public add1(): void {
    this.addandsub++;
    if (this.addandsub > 0) {
      this.flag = false;
    } else {
      this.flag = true;
    }
  }
  public sub1(): void {
    this.addandsub--;
    if (this.addandsub > 0) {
      this.flag = false;
    } else {
      this.flag = true;
    }
  }
}
