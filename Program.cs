﻿using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NeuroPlayClient.Forms;
using NeuroPlayClient.Services;
using NeuroPlayClient.Services.Implementations;
using NeuroPlayClient.Services.Interfaces;

namespace NeuroPlayClient {
    public static class Program {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            Application.Run(ServiceProvider.GetRequiredService<AuthForm>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder() {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddTransient<INeuroPlayService, NeuroPlayService>();
                    services.AddTransient<IFileSystemService, FileSystemService>();
                    services.AddSingleton<ISettingsService, SettingService>();
                    services.AddTransient<AuthForm>();
                    services.AddSingleton<FiguresExperiment>();
                });
        }
    }
}
