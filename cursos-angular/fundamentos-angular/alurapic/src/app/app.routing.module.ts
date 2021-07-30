import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { PhotoFormComponent } from './photos/photo-form/photo-form.component';
import { PhotoListComponent } from './photos/photo-list/photo-list.component';
import { NotFoundComponent } from './errors/not-found/not-found.component';

const routes: Routes  = [
    //{ path: 'user/flavio', component: PhotoListComponent, },
    { path: 'user/:userName', component: PhotoListComponent, }, // -> user/:nomeCoringa -> O sitema de rotas interpreta qualquer endereço que tenha o user/
    { path: 'p/add', component: PhotoFormComponent, },
    { path: '**', component: NotFoundComponent, }, //** = Qualquer rota que não seja as cadastradas
];

@NgModule({
    imports: [ RouterModule.forRoot(routes) ], // Import tá recebendo o resultado de router.module para saber o resultado das rotas
    exports: [ RouterModule ]
})
export class AppRoutingModule {}
