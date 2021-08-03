import { NgModule } from '@angular/core';

import { PhotoFormModule } from './photo-form/photo-form.module';
import { PhotoListModule } from './photo-list/photo-list.module';
import { PhotoModule } from './photo/photo.module';

@NgModule({
    declarations: [
      PhotoModule,
      PhotoFormModule,
      PhotoListModule
    ], // Está privado (Conceito Java)
    // Exports: [PhotoComponent], // Declara os módulos que serão acessiveis para quem importar o módulo (Público - Java)
})
export class PhotosModule { }
