﻿using Erm.BusinessLayer;

using FluentValidation;

namespace Project_ERM.Erm.BusinessLayer.Validators;

public sealed class RiskProfileInfoValidator : AbstractValidator<RiskProfileInfo>
{
    public RiskProfileInfoValidator()
    {
        RuleFor(prop => prop.Name).NotEmpty().MinimumLength(3).MaximumLength(50);
        RuleFor(prop => prop.Description).NotEmpty().MinimumLength(3).MaximumLength(500);
        RuleFor(prop => prop.BusinessProcess).NotEmpty().MinimumLength(3).MaximumLength(50);
        RuleFor(prop => prop.OccurrenceProbability).GreaterThanOrEqualTo(1).LessThanOrEqualTo(10);
        RuleFor(prop => prop.PotentialBusinessImpact).GreaterThanOrEqualTo(1).LessThanOrEqualTo(10);
    }
}