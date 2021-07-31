import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { PhotoComponent } from './photo/photo.component';
import { PhotoListComponent } from './photo-list/photo-list.component';
import { CommonModule } from '@angular/common';
import { PhotoFormComponent } from './photo-form/photo-form.component';
import { PhotosComponent } from './photo-list/photos/photos.component';

@NgModule({
    declarations: [
        PhotoComponent,
        PhotoListComponent,
        PhotoFormComponent,
        PhotosComponent
    ], // Está privado (Conceito Java)
    //exports: [PhotoComponent], // Declara os módulos que serão acessiveis para quem importar o módulo (Público - Java)
    imports: [
        HttpClientModule,
        CommonModule // Boa prática importar o CommonModule para puxar as diretivas usadads no BrowserModule
    ]
})
export class PhotosModule { }
