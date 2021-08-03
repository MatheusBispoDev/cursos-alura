import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subject } from 'rxjs';
import { debounceTime } from 'rxjs/operators'; // RxJS e seu Subject

import { Photo } from '../photo/photo';
import { PhotoService } from './../photo/photo.service';

// Componente que é responsável por atualizar a lista de fotos

@Component({
  // tslint:disable-next-line: component-selector
  selector: 'ap-photo-list',
  templateUrl: './photo-list.component.html',
  styleUrls: ['./photo-list.component.css'],
})
export class PhotoListComponent implements OnInit, OnDestroy {
  photos: Photo[] = [];
  // tslint:disable-next-line: no-inferrable-types
  filter: string = '';
  debounce: Subject<string> = new Subject<string>();
  // tslint:disable-next-line: no-inferrable-types
  hasMore: boolean = true;
  currentPage = 1;
  // tslint:disable-next-line: no-inferrable-types
  userName: string = '';

  // Construtor = somente injeção de dependências
  constructor(
    private activatedRoute: ActivatedRoute, // Serviço ActivatedRoute para ter acesso ao Coringa (userName) que esta na rota
    private photoService: PhotoService,
  ) {}

  // OnInit ocorre depois da instanciação de AppComponent, e depois do componente receber as inbound properties
  // OnInit = códigos de inicialização de configuração
  ngOnInit(): void {
    this.userName = this.activatedRoute.snapshot.params.userName;
    this.photos = this.activatedRoute.snapshot.data['photos'];
    // Será ignorado todas as transmissões e só será passadoa para o subscribe depois de 300 ms
    this.debounce
      .pipe(debounceTime(300))
      .subscribe(filter => this.filter = filter);
  }

  // OnDestroy será chamado toda que vez um componente é destruído
  ngOnDestroy(): void {
    this.debounce.unsubscribe(); // Precisa fazer para tirar esse subscribe da memória
  }

  load() {
    this.photoService
    .listFromUserPaginated(this.userName, ++this.currentPage)
    .subscribe(photos => {
      // this.photos.push(...photos); // Faz push de cada item de photos
      this.photos = this.photos.concat(photos); // Vai concatenar e gerar uma nova lista
      if (!photos.length) {
        this.hasMore = false;
      }
    });
  }
}
