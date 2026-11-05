import { Component } from '@angular/core';
import { EncabezadoComponent } from './components/encabezado/encabezado.component';
import { FormularioCursoComponent } from './components/formulario-curso/formulario-curso.component';
import { ListaCursosComponent } from './components/lista-cursos/lista-cursos.component';
import { PiePaginaComponent } from './components/pie-pagina/pie-pagina.component';
import { Curso } from './models/curso.model';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [EncabezadoComponent, FormularioCursoComponent, ListaCursosComponent, PiePaginaComponent],
  styleUrl: './app.component.css',
  templateUrl: './app.component.html',
})
export class AppComponent {
  cursos: Curso[] = [
    { id: 1, nombre: 'Desarrollo de Aplicaciones Web', docente: 'Ana Torres', activo: true },
    { id: 2, nombre: 'Base de Datos', docente: 'Carlos Mena', activo: true },
    { id: 3, nombre: 'Programacion Orientada a Objetos', docente: 'Maria Lopez', activo: false }
  ];

  agregarCurso(datos: Omit<Curso, 'id'>): void {
    const siguienteId = this.cursos.length > 0
      ? Math.max(...this.cursos.map(curso => curso.id)) + 1
      : 1;

    this.cursos = [...this.cursos, { id: siguienteId, ...datos }];
  }

  cambiarEstado(id: number): void {
    this.cursos = this.cursos.map(curso =>
      curso.id === id ? { ...curso, activo: !curso.activo } : curso
    );
  }

  eliminarCurso(id: number): void {
    this.cursos = this.cursos.filter(curso => curso.id !== id);
  }
}
