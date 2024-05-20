
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FeedbackService {
  private feedbackUrl = 'http://localhost:5080/Feedback';

  constructor(private http: HttpClient) { }

  submitFeedback(feedbackData: any): Observable<any> {
    return this.http.post<any>(this.feedbackUrl, feedbackData);
  }
}
