import { ApplicationConfig } from "@angular/core";

import { provideRouter } from "@angular/router";
import { provideAnimationsAsync } from "@angular/platform-browser/animations/async";
import { provideHttpClient } from "@angular/common/http";
import { provideToastr } from 'ngx-toastr'
import { routes } from "./app.route";


export const appConfig: ApplicationConfig = {
providers: [provideRouter(routes),
            provideAnimationsAsync(),
            provideHttpClient(),
            provideToastr({
              timeOut: 10000,
              positionClass: 'toast-bottom-right',
              preventDuplicates: true,
            })
          ]
}
