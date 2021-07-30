import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { PhotoFormComponent } from './photos/photo-form/photo-form.component';
import { PhotoListComponent } from './photos/photo-list/photo-list.component';

const routes: Routes  = [
    { path: 'user/flavio', component: PhotoListComponent, },
    { path: 'p/add', component: PhotoFormComponent, },
];

@NgModule({
    imports: [ RouterModule.forRoot(routes) ], // Import tá recebendo o resultado de router.module para saber o resultado das rotas
    exports: [ RouterModule ]
})
export class AppRoutingModule {}
