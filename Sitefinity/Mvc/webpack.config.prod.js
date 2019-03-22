import HtmlWebpackPlugin from 'html-webpack-plugin';
import CopyWebpackPlugin from 'copy-webpack-plugin';
import MiniCssExtractPlugin from 'mini-css-extract-plugin';
import path from 'path';
import { entry } from './tools/config.entry';

export default {
  resolve: {
    extensions: ['*', '.js', '.jsx', '.json']
  },
  mode: 'production',
  entry,
  output: {
    path: path.resolve(__dirname, '../Mvc.Bundle'), // Note: Physical files are only output by the production build task `npm run build`.
    filename: '[name].bundle.js',
  },
  optimization: {
    splitChunks: {
      chunks: 'all'
    }
  },
  plugins: [
    // Generate HTML file that contains references to generated bundles. See here for how this works: https://github.com/ampedandwired/html-webpack-plugin#basic-usage
    new HtmlWebpackPlugin({
      template: 'Templates/index.ejs',
      minify: {
        removeComments: true,
        collapseWhitespace: true,
        removeRedundantAttributes: true,
        useShortDoctype: true,
        removeEmptyAttributes: true,
        removeStyleLinkTypeAttributes: true,
        keepClosingSlash: true,
        minifyJS: true,
        minifyCSS: true,
        minifyURLs: true
      },
      inject: true,
      // Note that you can add custom options here if you need to handle other custom logic in index.html
      // To track JavaScript errors via TrackJS, sign up for a free trial at TrackJS.com and enter your token below.
      trackJSToken: ''
    }),

    new CopyWebpackPlugin([
      {
        from: 'Assets/Images',
        to: 'Assets/Images'
      },
      {
        from: 'Assets/Fonts',
        to: 'Assets/Fonts'
      }
    ]),

    new MiniCssExtractPlugin({
      filename: '[name].bundle.css'
    }),

  ],
  module: {
    rules: [
      {
        test: /\.js|\.jsx?$/,
        exclude: /node_modules/,
        use: ['babel-loader']
      },
      {
        test: /(\.css|\.scss|\.sass)$/,
        use: [
          MiniCssExtractPlugin.loader,
          {
            loader: 'css-loader',
            options: {
              sourceMap: true
            }
          },
          {
            loader: 'postcss-loader',
            options: {
              plugins: () => [
                require('cssnano'),
                require('autoprefixer'),
              ],
              sourceMap: true
            }
          },
          {
            loader: 'sass-loader',
            options: {
              includePaths: [path.resolve(__dirname, '../Mvc.Bundle/Styles')],
              sourceMap: true
            }
          }
        ]
      },
      {
        test: /\.svg(\?v=\d+\.\d+\.\d+)?$/,
        use: [
          {
            loader: 'url-loader',
            options: {
              limit: 10000,
              mimetype: 'image/svg+xml',
              name: '[name].[ext]'
            }
          },
        ]
      },
      {
        test: /\.(jpe?g|png|gif|ico)$/i,
        use: [
          {
            loader: 'file-loader',
            options: {
              name: 'Assets/Images/[name].[ext]',
            }
          }
        ]
      },
      {
        test: /\.(woff(2)?|ttf|eot)(\?v=\d+\.\d+\.\d+)?$/,
        use: [
          {
            loader: 'file-loader',
            options: {
              name: 'Assets/Fonts/[name].[ext]'
            }
          }
        ]
      },
    ]
  },
}
