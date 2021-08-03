import { Component, Input } from '@angular/core';

@Component({
    // tslint:disable-next-line: component-selector
    selector: 'ap-photo',
    templateUrl: 'photo.component.html',
})

export class PhotoComponent {
    // Explicitar que esses atríbutos podem ser recebidos como parâmetro
    // Input =  Inbound properties: passando dados para o componente

    @Input() description = '';

    @Input() url = '';
}
