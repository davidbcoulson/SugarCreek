import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateRoundsComponent } from './create-rounds.component';

describe('CreateRoundsComponent', () => {
  let component: CreateRoundsComponent;
  let fixture: ComponentFixture<CreateRoundsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateRoundsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateRoundsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
