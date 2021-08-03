import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';

import { Photo } from '../../photo/photo';

// Componente que é responsável por renderizar os dados (lista)
@Component({
  // tslint:disable-next-line: component-selector
  selector: 'ap-photos',
  templateUrl: './photos.component.html',
  styleUrls: ['./photos.component.css'],
})
export class PhotosComponent implements OnChanges {
  @Input() photos: Photo[] = [];
  rows: any[] = [];

  constructor() {}

  // o OnChagens vai ser executado toda vez que houver alteração nas inbound properties do componentes
  ngOnChanges(changes: SimpleChanges) {
    // Changes.photos = verifica se foi alterada a propriedade photos
    if (changes.photos) {
      this.rows = this.groupColumns(this.photos);
    }
  }

  groupColumns(photos: Photo[]) {
    const newRows = [];

    for (let index = 0; index < photos.length; index += 3) {
      newRows.push(photos.splice(index, index + 3));
      // splice funciona como um separador de array
      // o primeiro parâmetro marca a posição inicial que pegará o valor
      // o segundo parâmetro marca a pos final (index) *Não pega o valor que o index parou, se o valor final for 3 só pegará o anterior (2)
    }

    return newRows;
  }
}
