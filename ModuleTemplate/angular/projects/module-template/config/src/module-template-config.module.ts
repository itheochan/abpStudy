import { ModuleWithProviders, NgModule } from '@angular/core';
import { MODULE_TEMPLATE_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class ModuleTemplateConfigModule {
  static forRoot(): ModuleWithProviders<ModuleTemplateConfigModule> {
    return {
      ngModule: ModuleTemplateConfigModule,
      providers: [MODULE_TEMPLATE_ROUTE_PROVIDERS],
    };
  }
}
