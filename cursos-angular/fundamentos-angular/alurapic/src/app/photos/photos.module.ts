import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { PhotoComponent } from './photo/photo.component';


@NgModule({
    declarations: [ PhotoComponent ], // Está privado (Conceito Java)
    exports: [ PhotoComponent ], // Declara os módulos que serão acessiveis para quem importar o módulo (Público - Java)
    imports: [ HttpClientModule ]
})
export class PhotosModule {}
