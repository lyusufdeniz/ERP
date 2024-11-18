import { HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { SwalService } from './swal.service';

@Injectable({
  providedIn: 'root',
})
export class ErrorService {
  constructor(private swal: SwalService) {}

  errorHandler(err: HttpErrorResponse) {
    let errorMessage = 'Bir hata oluştu.';

    // 4xx Hataları (İstemci Hataları)
    if (err.status >= 400 && err.status < 500) {
      switch (err.status) {
        case 400:
          errorMessage = 'Geçersiz istek. Lütfen verilerinizi kontrol edin.';
          break;
        case 401:
          errorMessage = 'Yetkisiz erişim. Lütfen giriş yapın.';
          break;
        case 403:
          if (err.error?.ErrorMessages) {
            errorMessage = err.error.ErrorMessages.join('\n');
          } else {
            errorMessage = 'Bu işlemi gerçekleştirmek için yetkiniz yok.';
          }
          break;
        case 404:
          errorMessage = 'Aradığınız kaynak bulunamadı.';
          break;
        default:
          errorMessage = err.error?.message || 'İstemci hatası oluştu.';
      }
    }
    // 5xx Hataları (Sunucu Hataları)
    else if (err.status >= 500 && err.status < 600) {
      switch (err.status) {
        case 500:
          errorMessage = err.error?.errorMessages
            ? err.error.errorMessages[0]
            : 'Sunucuda bir hata oluştu.';
          break;
        case 503:
          errorMessage = 'Sunucu şu anda hizmet veremiyor. Lütfen daha sonra tekrar deneyin.';
          break;
        default:
          errorMessage = err.error?.message || 'Sunucu hatası oluştu.';
      }
    }
    // Diğer Hata Durumları
    else if (err.status === 0) {
      errorMessage = 'Sunucuya ulaşılamıyor. İnternet bağlantınızı kontrol edin.';
    } else {
      errorMessage = err.error?.message || 'Bilinmeyen bir hata oluştu.';
    }

    // Hata Mesajını Göster
    this.swal.callToast(errorMessage, 'error');
  }
}
