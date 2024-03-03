﻿using HB.Domain.Models.HotelBed;
using HB.Domain.Shared;
using MediatR;

namespace HB.Application.Features.Hotel.Queries.GetLocations;
public record GetLocationsRequest : IRequest<Result<HotelLocationResponse, Error>>;