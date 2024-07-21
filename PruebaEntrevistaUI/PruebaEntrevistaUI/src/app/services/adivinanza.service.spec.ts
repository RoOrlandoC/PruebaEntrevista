import { TestBed } from '@angular/core/testing';

import { AdivinanzaService } from './adivinanza.service';

describe('AdivinanzaService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: AdivinanzaService = TestBed.get(AdivinanzaService);
    expect(service).toBeTruthy();
  });
});
