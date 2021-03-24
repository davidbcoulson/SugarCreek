import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GetRoundsComponent } from './get-rounds.component';

describe('GetRoundsComponent', () => {
  let component: GetRoundsComponent;
  let fixture: ComponentFixture<GetRoundsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GetRoundsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GetRoundsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
