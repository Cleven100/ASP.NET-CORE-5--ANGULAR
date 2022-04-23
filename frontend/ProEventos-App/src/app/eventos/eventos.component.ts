import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any = [


    {
      Tema: 'Angular 11',
      Local: 'Belo Horizonte'
     },
     {
      Tema: '.net 5',
      Local: 'São paulo'
     },
     {
      Tema: 'Angular e suas novidades',
      Local: 'Rio de janeiro'
     }
]

  constructor() { }

  ngOnInit(): void {
  }

}
