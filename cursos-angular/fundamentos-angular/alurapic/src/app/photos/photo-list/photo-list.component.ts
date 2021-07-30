
import { Component, OnInit } from '@angular/core';
import { PhotoService } from '../photo/photo.service';

@Component({
  selector: 'ap-photo-list',
  templateUrl: './photo-list.component.html',
  styleUrls: ['./photo-list.component.css']
})
export class PhotoListComponent implements OnInit {

  photos: any[] = [];

  // Construtor = somente injeção de dependências
  constructor(private photoService: PhotoService) { }

  // OnInit ocorre depois da instanciação de AppComponent, e depois do componente receber as inbound properties
  // OnInit = códigos de inicialização de configuração
  ngOnInit(): void {
      this.photoService.listFromUser('flavio').subscribe((photos) => {
      console.log(photos[0].description);
      this.photos = photos;
    });
  }

}
