import { Component, OnInit } from '@angular/core';
import { ModuleTemplateService } from '../services/module-template.service';

@Component({
  selector: 'lib-module-template',
  template: ` <p>module-template works!</p> `,
  styles: [],
})
export class ModuleTemplateComponent implements OnInit {
  constructor(private service: ModuleTemplateService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
