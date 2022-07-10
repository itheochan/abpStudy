import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { ModuleTemplateComponent } from './module-template.component';

describe('ModuleTemplateComponent', () => {
  let component: ModuleTemplateComponent;
  let fixture: ComponentFixture<ModuleTemplateComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ ModuleTemplateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ModuleTemplateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
