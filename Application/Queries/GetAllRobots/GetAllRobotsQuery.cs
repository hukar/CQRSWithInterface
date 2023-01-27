using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSWithInterface.Application.Interfaces;
using CQRSWithInterface.Models;
using MediatR;

namespace CQRSWithInterface.Application.Queries.GetAllRobots;

public record GetAllRobotsQuery : IQuery<IEnumerable<Robot>>;