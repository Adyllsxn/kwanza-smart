#region Microsoft
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Storage;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.SignalR;
global using KwanzaSmart.Server.Source.Presentation.Hubs;
#endregion

#region Partial
global using Scalar.AspNetCore;
global using System.Net;
#endregion

#region KwanzaSmart
global using KwanzaSmart.Server.Source.Domain.Abstractions.Exceptions;
global using KwanzaSmart.Server.Source.Domain.Abstractions.Validator;
global using KwanzaSmart.Server.Source.Domain.Entities.Base;
global using KwanzaSmart.Server.Source.Domain.Enums;
global using KwanzaSmart.Server.Source.Domain.Entities; 
global using KwanzaSmart.Server.Source.Domain.Interfaces;
global using KwanzaSmart.Server.Source.Infrastructure.Data.Context;
global using KwanzaSmart.Server.Source.Infrastructure.Data.Connection;
global using KwanzaSmart.Server.Source.Infrastructure.Services;
global using KwanzaSmart.Server.Source.Infrastructure.UoW;
global using KwanzaSmart.Server.Source.Presentation.Common.Configs;
global using KwanzaSmart.Server.Source.Presentation.Common.Extensions;
global using KwanzaSmart.Server.Source.Presentation.Common.Middleware;
global using KwanzaSmart.Server.Source.Presentation.Common.Pipeline;
global using KwanzaSmart.Server.Source.Presentation.Enpoints;
global using KwanzaSmart.Server.Source.Presentation.Enpoints.System;
global using KwanzaSmart.Server.Source.Presentation.Enpoints.Business.Alerta.Commands;
global using KwanzaSmart.Server.Source.Presentation.Enpoints.Business.Alerta.Queries;
global using KwanzaSmart.Server.Source.Presentation.Enpoints.Business.Alerta.DTOs;
global using KwanzaSmart.Server.Source.Presentation.Enpoints.Business.Comando.Commands;
global using KwanzaSmart.Server.Source.Presentation.Enpoints.Business.Comando.Queries;
global using KwanzaSmart.Server.Source.Presentation.Enpoints.Business.Comando.DTOs;
global using KwanzaSmart.Server.Source.Presentation.Enpoints.Business.LeituraSensor.Commands;
global using KwanzaSmart.Server.Source.Presentation.Enpoints.Business.LeituraSensor.Queries;
global using KwanzaSmart.Server.Source.Presentation.Enpoints.Business.LeituraSensor.DTOs;
#endregion
