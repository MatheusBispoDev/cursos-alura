import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

import { Photo } from '../photo/photo';
import { PhotoService } from '../photo/photo.service';

@Component({
  selector: 'ap-photo-list',
  templateUrl: './photo-list.component.html',
  styleUrls: ['./photo-list.component.css']
})
export class PhotoListComponent implements OnInit {

  photos: Photo[] = [];

  // Construtor = somente injeção de dependências
  constructor(
    private photoService: PhotoService,
    private activatedRoute: ActivatedRoute, //Serviço ActivatedRoute para ter acesso ao Coringa (userName) que esta na rota
  ) { }

  // OnInit ocorre depois da instanciação de AppComponent, e depois do componente receber as inbound properties
  // OnInit = códigos de inicialização de configuração
  ngOnInit(): void {
    //Pega o valor das rotas
    const userName = this.activatedRoute.snapshot.params.userName;

    this.photoService.listFromUser(userName).subscribe((photos) => {
      this.photos = photos;
    });
  }

}
