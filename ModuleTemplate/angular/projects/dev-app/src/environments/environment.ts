import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'ModuleTemplate',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44337',
    redirectUri: baseUrl,
    clientId: 'ModuleTemplate_App',
    responseType: 'code',
    scope: 'offline_access ModuleTemplate role email openid profile',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44337',
      rootNamespace: 'Theo.ModuleTemplate',
    },
    ModuleTemplate: {
      url: 'https://localhost:44399',
      rootNamespace: 'Theo.ModuleTemplate',
    },
  },
} as Environment;
