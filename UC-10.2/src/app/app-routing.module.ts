import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CadastroProdutoComponent } from './cadastro-produto/cadastro-produto.component';
import { PainelPrincipalComponent } from './painel-principal/painel-principal.component';

const routes: Routes = [
  { path: 'painel-principal', component: PainelPrincipalComponent },
  { path: 'cadastro-produto', component: CadastroProdutoComponent }, // Cadastro de novo produto
  { path: 'cadastro-produto/:id', component: CadastroProdutoComponent }, // Edição de produto
  { path: '', redirectTo: '/painel-principal', pathMatch: 'full' } // Redirecionamento padrão
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
