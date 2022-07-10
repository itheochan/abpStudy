import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { ModuleTemplateComponent } from './components/module-template.component';
import { ModuleTemplateRoutingModule } from './module-template-routing.module';

@NgModule({
  declarations: [ModuleTemplateComponent],
  imports: [CoreModule, ThemeSharedModule, ModuleTemplateRoutingModule],
  exports: [ModuleTemplateComponent],
})
export class ModuleTemplateModule {
  static forChild(): ModuleWithProviders<ModuleTemplateModule> {
    return {
      ngModule: ModuleTemplateModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<ModuleTemplateModule> {
    return new LazyModuleFactory(ModuleTemplateModule.forChild());
  }
}
