import { Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class ModuleTemplateService {
  apiName = 'ModuleTemplate';

  constructor(private restService: RestService) {}

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/ModuleTemplate/sample' },
      { apiName: this.apiName }
    );
  }
}
