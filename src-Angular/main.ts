
import { Component } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms'; // Import FormBuilder and Validators

@Component({
  selector: 'app-feedback',
  templateUrl: './feedback.component.html',
  styleUrls: ['./feedback.component.css']
})
export class FeedbackComponent {
  feedbackForm!: FormGroup;
  constructor(private formBuilder: FormBuilder) { 
    this.createFeedbackForm(); 
  }

  createFeedbackForm(): void {
    this.feedbackForm = this.formBuilder.group({ 
      name: ['', Validators.required], 
      email: ['', [Validators.required, Validators.email]],
      message: ['', Validators.required]
    });
  }

  onSubmit(): void {
    if (this.feedbackForm.valid) { 
      
      console.log(this.feedbackForm.value); 
    } else {
      
      this.markFormGroupTouched(this.feedbackForm);
    }
  }

  markFormGroupTouched(formGroup: FormGroup): void {
    Object.values(formGroup.controls).forEach(control => {
      if (control instanceof FormGroup) {
        this.markFormGroupTouched(control);
      } else {
        control.markAsTouched(); 
      }
    });
  }
}

    
