import { TestBed } from '@angular/core/testing';

import { ModuleTemplateService } from './module-template.service';

describe('ModuleTemplateService', () => {
  let service: ModuleTemplateService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ModuleTemplateService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
